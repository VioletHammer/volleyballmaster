using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    public string name { get; set; }
    public string lastName { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public long id { get; set; }

    public User(string name, string lastName, string password, string email, long id)
    {
        this.name = name;
        this.lastName = lastName;
        this.password = password;
        this.email = email;
        this.id = id;
    }
}
