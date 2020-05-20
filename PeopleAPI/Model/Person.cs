using System;
using System.ComponentModel.DataAnnotations;

namespace PeopleAPI.Model
{
    public class Person
    {

        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
