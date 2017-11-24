using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.BusinessLayer
{
    public class User
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        
        public User(string id,string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return string.Format($"Id= {Id}, Name= {Name}");
        }

        public bool IsIdExist(string id)
        {
            if (Id == id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsTitleExist(string name)
        {
            return (Name == name);
        }
    }
}
    