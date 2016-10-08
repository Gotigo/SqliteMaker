using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteMaker
{
    public class Tables
    {

        public static List<Table> ListTable { get; set; }

        public override string ToString()
        {
            StringBuilder list = new StringBuilder();
            foreach (var table in Tables.ListTable)
            {
                list.Append(string.Format("\r\nstring final table_{0} = \"",table.Name));
                list.Append(table.ToString());
                list.Append("\";");
            }

            return list.ToString();
        }
    }

    public class Table
    {
        public Table(int id,string name)
        {
            this.Name = name;
            this.Id = id;
            this.ListColumn = new List<Column>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Column> ListColumn { get; set; }

        public override string ToString()
        {
            StringBuilder table = new StringBuilder();
            table.Append("CREATE TABLE " + this.Name + "(");
            foreach (var column in this.ListColumn)
            {
                if (column.Id == this.ListColumn.Last().Id)
                    break;

                string key = column.IsPK ? "PRIMARY KEY" : (column.IsUnique ? "UNIQUE" : "");
                table.Append(string.Format("\r\n {0} {1} {2},",column.Name,column.Type.ToUpper(),key));
            }
            table.Remove(table.Length - 1, 1);
            table.Append(")");
            return table.ToString();
        }
    }

    public class Column
    {
        public Column(int id,
            string name,
            string type,
            bool isrowid = false,
            bool ispk = false,
            bool isunique = false)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.IsRowId = isrowid;
            this.IsPK = ispk;
            this.IsUnique = isunique;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsRowId { get; set; }
        public bool IsPK { get; set; }
        public bool IsUnique { get; set; }
    }

    public class Types
    {
        public string name { get; set; }
        public string value
        {
            get { return name; }
        }

        public Types(string name)
        {
            this.name = name;
        }

        public Types()
        {
        }

        public static List<Types> ListTypes()
        {
            List<Types> listTypes = new List<Types>();
            listTypes.Add(new Types("integer"));
            listTypes.Add(new Types("text"));
            listTypes.Add(new Types("blob"));
            listTypes.Add(new Types("real"));
            listTypes.Add(new Types("numeric"));
            return listTypes;
        }
    }
}
