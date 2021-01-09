using SQLite;
using System;

namespace PersonalAgenda.Models {
   public class Agenda {
        [PrimaryKey, AutoIncrement]
        public int ID {
            get;
            set;
        }

        public String Text {
            get;
            set;
        }

        public DateTime Date {
            get;
            set;
        }
    }
}
