/*Kasey Sanderson SPC ID 2506815
 COP 2839 - Week 1 Assignment
8/20/2025
Collaborators: learn.microsoft.com, 
"Architecting Modern Web Applications.." by
Steve "Ardalis" Smith*/

namespace ksanderson_week1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
