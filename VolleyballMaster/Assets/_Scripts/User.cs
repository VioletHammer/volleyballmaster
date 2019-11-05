using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private string name { get; set; }
    private string lastName { get; set; }
    private string password { get; set; }
    private string email { get; set; }
    private long id { get; set; }

    public User(string name, string lastName, string password, string email, long id)
    {
        this.name = name;
        this.lastName = lastName;
        this.password = password;
        this.email = email;
        this.id = id;
    }
}
