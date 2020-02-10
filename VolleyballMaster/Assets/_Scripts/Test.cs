using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json;
using System.IO;

public class Test : MonoBehaviour
{
    public Foo h;
    [Serializable]
    public class Foo
    {
        public int a;
        public string s = "algo";
        public Foo internalFoo = null;
    }


    void Start()
    {
        Foo f = new Foo();
        f.internalFoo = new Foo();
        f.s = "Hello";
        f.a = 3;
        f.internalFoo.a = 4;
        f.internalFoo.s = "Bye";
        string jsonFoo = JsonConvert.SerializeObject(f, Formatting.Indented);
        string path = Application.persistentDataPath;
        path += "/Test.txt";
        File.WriteAllText(path, jsonFoo);
        Debug.Log(path);

        string readJson;
        readJson = File.ReadAllText(path);
        h = JsonConvert.DeserializeObject<Foo>(readJson);
        Debug.Log(h.internalFoo.s);

        SingletonSample.Instance.Guava();
       
    }

}

