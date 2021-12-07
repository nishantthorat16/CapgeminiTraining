using System;
using System.ComponentModel.DataAnnotations;

namespace ABCLibrary
{
    public enum Role
    {
        Admin = 1,
        Member
    }

    public class User
    {
        [Key]
        public int Id           { get; set; }

        [Required]
        [StringLength(100,MinimumLength = 2)]
        public string Name      { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Email     { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Password  { get; set; }

        public Role  Role       { get; set; }
    }
}
