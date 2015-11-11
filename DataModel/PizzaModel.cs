using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [Table("Pizzas")]
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        [Required]
        public IEnumerable<Ingredient> Ingredients { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool IsStandart { get; set; }
    }

    [Table("Ingredients")]
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        public int Weight { get; set; }
    }

    [Table("OrderItems")]
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        [Required]
        public int Amount { get; set; }        
    }

    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(13)]
        public string CustomerPhone { get; set; }
        [Required]
        [MaxLength(255)]
        public string CustomerAddress { get; set; }
        [Required]
        public double TotalSum { get; set; }
        [Required]
        public IEnumerable<OrderItem> Items { get; set; }
    }

    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        public string Phone { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
