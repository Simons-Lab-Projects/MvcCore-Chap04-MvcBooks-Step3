using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBooks.Models
{
   public class Category
   {
      public int CategoryId { get; set; }
      public string Description { get; set; }

      public Category(int cid, string desc)
      {
         CategoryId = cid;
         Description = desc;
      }

      public Category()
      {
      }
   }
}
