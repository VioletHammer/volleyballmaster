using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Administrator: User
{
    private long id { get; set; }
    private string organization { get; set; }

    public Administrator(string name, string lastName, string password, string email, long id) : base(name, lastName, password, email, id)
    {
    }


   public bool insertUser(string name, string lastName, string password, string email, long id)
    {
        bool result = false;
        


        return result;
    }
    // Torneos

}
