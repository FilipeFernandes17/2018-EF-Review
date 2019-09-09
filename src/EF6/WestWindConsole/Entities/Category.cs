using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    // TODO: Begin reviewing entity attributes
    [Table("Categories", Schema = "dbo")]//dbo is default
    public class Category
    {
        [Key]// This property/column is a PK in the DB
        public int CategoryID { get; set; }

        [Required] // Use this for string/varchar columns that are NOT NULL
        [StringLength(15, ErrorMessage = "Category Name cannot be more than 15 characters long")]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }// image

        [StringLength(40, ErrorMessage = "Picture Mime Type has a maximum of 40 characters")]
        public string PictureMimeType { get; set; }

        // TODO: Introducing Navigation Properties
        //the virtual keyword allows our entity to support
        //"Lazy loading"
        //The iCollection<T> is an interface data type.
        //The HashSet<T> is a class that "implements" the 
        //ICollection<T> interface

        //saying each category can hold many products
        public virtual ICollection<Product> Products { get; set; } =
            new HashSet<Product>();
    }
}
