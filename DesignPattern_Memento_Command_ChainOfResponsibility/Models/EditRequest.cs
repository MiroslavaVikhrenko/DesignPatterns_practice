using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Memento_Command_ChainOfResponsibility.Models
{
    // A simple DTO representing an edit request
    public class EditRequest
    {
        public string Operation { get; set; } // "insert", "delete", "replace"
        public int Index { get; set; }
        public int Length { get; set; }       // For delete/replace
        public string Text { get; set; }      // For insert/replace
        public string Role { get; set; }      // "user", "moderator", "admin"
    }
}
