using System.Data.SqlClient;

string connectionString = @"Data Source=BS-1045\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True";
SqlConnection sqlConnection = new SqlConnection(connectionString);

sqlConnection.Open(); //---------------------------------------------------------
Console.WriteLine("coneection create hoiche! hurra!!!!");

int id = 70, roll = 20;
string name = "B";
string query = "";
SqlCommand cmd = new SqlCommand();

////CREATE
query = "insert into info(id, roll, name) values('" + id + "', '" + roll + "', '" + name + "')";
cmd = new SqlCommand(query, sqlConnection);
cmd.ExecuteNonQuery();

//READ
query = "select * from info";
cmd = new SqlCommand(query, sqlConnection);
SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine("id - " + reader.GetValue(0) +
        " roll - " + reader.GetValue(1) +
        " name - " + reader.GetValue(2));
}
reader.Close();

//UPDATE
roll = 100;
name = "A";
query = "update info set roll = '" + roll + "' where name = '" + name + "'";
cmd = new SqlCommand(query, sqlConnection);
cmd.ExecuteNonQuery();

//DELETE
roll = 100;
query = "delete from info where roll = '" + roll + "'";
cmd = new SqlCommand(query, sqlConnection);
cmd.ExecuteNonQuery();

sqlConnection.Close(); //---------------------------------------------------------