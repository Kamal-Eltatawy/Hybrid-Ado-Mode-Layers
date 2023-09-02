using System.Data;
using Business_Layers.Model;
using DataAccess;
using Microsoft.Data.SqlClient;

namespace Business_Layers
{
    public class TopicBl
    {
        DataContext dataContext;
        public TopicBl()
        {
        dataContext = new DataContext();
            
        }
        //select all return datatable
        public DataTable GetAllInDataTabel()
        {
            string command = "select * from topic";
           return dataContext.GetData(command);
        }

        // select all return sequance

        public List<Topic> GetAllInList()
        {
            string command = "select * from topic";
            dataContext = new DataContext();
           DataTable data= dataContext.GetData(command);
            List<Topic> list = new List<Topic>();
            foreach (DataRow item in data.Rows)
            {
                list.Add(new Topic()
                {
                    Id = (int)item["ID"],
                    Name = (string)item["Name"],
                }
                );;
            }
            return list;
        }

        //Insert
        public int Insert(string name)
        {
            string command = "insert into topic values(@name)";
            SqlParameter sqlParameter = new SqlParameter("name", name);
            dataContext = new DataContext();
            return dataContext.NonQueryExcution(command, sqlParameter);
        }
        //Update 
        public int Update(int id, string name)
        {
            string command = "update Topic set top_name =@name where top_id = @id";
            SqlParameter[] sqlParameter = new SqlParameter[2];
            sqlParameter[0] = new SqlParameter("id", id);
            sqlParameter[1] = new SqlParameter("name", name);
            dataContext = new DataContext();
            return dataContext.NonQueryExcution(command, sqlParameter);
        }
        //delete
        public int Delete(int id)
        {
            string command = "Delete from topic where top_id = @id";
            SqlParameter sqlParameter = new SqlParameter("id", id);
            dataContext = new DataContext();
            return dataContext.NonQueryExcution(command, sqlParameter);
        }
    }
        
}