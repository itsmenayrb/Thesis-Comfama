using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server.dirClasses
{
    class SubmitFeedback
    {
        public string connectionString = string.Empty;
        public string query = string.Empty;

        public SubmitFeedback()
        {
            Database database = new Database();
            this.connectionString = database.dbConnection();
        }

        internal bool submitFeedbackForComputerUnit(string ticketNumber, string findings, string typeOfHardware, int selectedUnit, string actionTaken, string feedback)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO RequestAssistanceFeedback (ticketNumber, findings, typeOfHardware, computerUnit, actionTaken, feedback, dateResponded) VALUES (@ticketNumber, @findings, @typeOfHardware, @computerUnit, @actionTaken, @feedback, @dateResponded)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticketNumber", ticketNumber);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@typeOfHardware", typeOfHardware);
                        cmd.Parameters.AddWithValue("@computerUnit", selectedUnit);
                        cmd.Parameters.AddWithValue("@actionTaken", actionTaken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@dateResponded", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on submitting feedback for computer unit: " + ex.Message);
                return false;
            }
        }

        internal bool updateReportStatus(string ticketNumber, string status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE RequestAssistance SET status=@status WHERE ticketNumber=@ticketNumber";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticketNumber", ticketNumber);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on updating status of report: " + ex.Message);
                return false;
            }
        }

        public int hasSameReportForThisUnit(string ticketNumber, int computerUnit)
        {
            int counter = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT COUNT(*) as reportCount FROM RequestAssistanceFeedback WHERE ticketNumber=@ticketNumber AND computerUnit=@computerUnit";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticketNumber", ticketNumber);
                        cmd.Parameters.AddWithValue("@computerUnit", computerUnit);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            counter = Convert.ToInt32(reader["reportCount"]);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on updating status of report: " + ex.Message);
            }
            return counter;
        }

        internal void addReportCountForThisUnit(int selectedUnit)
        {
            int count = getReportCountOfThisUnit(selectedUnit) + 1;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE RemotePC SET reportCount=@reportCount WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@reportCount", count);
                        cmd.Parameters.AddWithValue("@id", selectedUnit);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on adding report count on this unit: " + ex.Message);
            }   
        }

        private int getReportCountOfThisUnit(int selectedUnit)
        {
            int currentCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT reportCount FROM RemotePC WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", selectedUnit);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            currentCount = reader["reportCount"] == DBNull.Value ? 0 : Convert.ToInt32(reader["reportCount"]);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on getting report count of unit: " + ex.Message);
            }
            return currentCount;
        }

        internal int hasSameReportForThisItem(string ticketNumber, int selectedItem)
        {
            int counter = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT COUNT(*) as reportCount FROM RequestAssistanceFeedback WHERE ticketNumber=@ticketNumber AND replacedItem=@replacedItem";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticketNumber", ticketNumber);
                        cmd.Parameters.AddWithValue("@replacedItem", selectedItem);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            counter = Convert.ToInt32(reader["reportCount"]);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on updating status of report: " + ex.Message);
            }
            return counter;
        }

        internal void addReportCountForThisItem(int selectedItem)
        {
            int count = getReportCountOfThisItem(selectedItem) + 1;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE InventoryItems SET reportCount=@reportCount WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@reportCount", count);
                        cmd.Parameters.AddWithValue("@id", selectedItem);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on adding report count on this item: " + ex.Message);
            }   
        }

        private int getReportCountOfThisItem(int selectedItem)
        {
            int currentCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT reportCount FROM InventoryItems WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", selectedItem);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            currentCount = reader["reportCount"] == DBNull.Value ? 0 : Convert.ToInt32(reader["reportCount"]);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on getting report count of item: " + ex.Message);
            }
            return currentCount;
        }

        internal bool submitFeedbackForItem(string ticketNumber, string findings, string typeOfHardware, int selectedItem, int replacedWithThisItem, string actionTaken, string feedback)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO RequestAssistanceFeedback (ticketNumber, findings, typeOfHardware, replacedItem, replacedWith, actionTaken, feedback, dateResponded) VALUES (@ticketNumber, @findings, @typeOfHardware, @replacedItem, @replacedWith, @actionTaken, @feedback, @dateResponded)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticketNumber", ticketNumber);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@typeOfHardware", typeOfHardware);
                        cmd.Parameters.AddWithValue("@replacedItem", selectedItem);
                        cmd.Parameters.AddWithValue("@replacedWith", replacedWithThisItem);
                        cmd.Parameters.AddWithValue("@actionTaken", actionTaken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@dateResponded", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on submitting feedback for item: " + ex.Message);
                return false;
            }
        }

        internal bool replaceItem(int selectedItem, int replacedWithThisItem)
        {
            int newLocation = getReplacedWithThisItemLocation(replacedWithThisItem);
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE InventoryItems SET location=@location WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", selectedItem);
                        cmd.Parameters.AddWithValue("@location", newLocation);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    
                }

                //SqlConnection.ClearAllPools();

                //using (SqlConnection conn = new SqlConnection(this.connectionString))
                //{
                //    conn.Open();
                //    this.query = "UPDATE InventoryItems SET location=@location WHERE id=@id";
                //    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                //    {
                //        cmd.Parameters.Clear();
                //        cmd.Parameters.AddWithValue("@id", selectedItem);
                //        cmd.Parameters.AddWithValue("@location", replacedWithThisItem);
                //        cmd.ExecuteNonQuery();
                //    }
                //    conn.Close();
                //}

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on updating status of report: " + ex.Message);
                return false;
            }

        }

        private int getReplacedWithThisItemLocation(int replacedWithThisItem)
        {
            int location = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "SELECT location FROM InventoryItems WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", replacedWithThisItem);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            location = Convert.ToInt32(reader["location"]);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on updating status of report: " + ex.Message);
            }
            return location;
        }

        internal bool setNewStatusOFReplaceItem(int selectedItem, string selectedItemNewStatus)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "UPDATE InventoryItems SET status=@status WHERE id=@id";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", selectedItem);
                        cmd.Parameters.AddWithValue("@status", selectedItemNewStatus);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();

                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on updating status of report: " + ex.Message);
                return false;
            }
        }

        internal bool submitFeedbackForItemTroubleshoot(string ticketNumber, string findings, string typeOfHardware, int selectedItem, string actionTaken, string feedback)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO RequestAssistanceFeedback (ticketNumber, findings, typeOfHardware, replacedItem, actionTaken, feedback, dateResponded) VALUES (@ticketNumber, @findings, @typeOfHardware, @replacedItem, @actionTaken, @feedback, @dateResponded)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticketNumber", ticketNumber);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@typeOfHardware", typeOfHardware);
                        cmd.Parameters.AddWithValue("@replacedItem", selectedItem);
                        cmd.Parameters.AddWithValue("@actionTaken", actionTaken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@dateResponded", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on submitting feedback for item: " + ex.Message);
                return false;
            }
        }

        internal bool submitFeedbackForSoftware(string ticketNumber, string findings, string actionTaken, string feedback)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    this.query = "INSERT INTO RequestAssistanceFeedback (ticketNumber, findings, actionTaken, feedback, dateResponded) VALUES (@ticketNumber, @findings, @actionTaken, @feedback, @dateResponded)";
                    using (SqlCommand cmd = new SqlCommand(this.query, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ticketNumber", ticketNumber);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@actionTaken", actionTaken);
                        cmd.Parameters.AddWithValue("@feedback", feedback);
                        cmd.Parameters.AddWithValue("@dateResponded", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on submitting feedback for item: " + ex.Message);
                return false;
            }
        }
    }
}
