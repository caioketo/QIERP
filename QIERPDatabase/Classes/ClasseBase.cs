using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIERPDatabase.Classes
{
    public class ClasseBase
    {
        [Key]
        public int Id { get; set; }
        public Nullable<DateTime> DataExclusao { get; set; }

        public ClasseBase()
        {
            this.Id = -1;
        }

        public ClasseBase(int id)
        {
            this.Id = id;
        }
    }
}
