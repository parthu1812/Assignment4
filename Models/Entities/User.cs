﻿using System;
using System.Collections.Generic;

namespace Assignment4.Models.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? DateCreated { get; set; }
}
