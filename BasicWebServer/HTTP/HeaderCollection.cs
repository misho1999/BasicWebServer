using System.Collections;
using System.Collections.Generic;

namespace BasicWebServer.HTTP
{
    public class HeaderCollection : IEnumerable<Header>
    {
        private readonly Dictionary<string, Header> headers = new Dictionary<string, Header>();

        public int Count => headers.Count;

        public string this[string name] => this.headers[name].Value;

        public void Add(string name, string value) => this.headers[name] = new Header(name, value);
        //{
        //    //TODO: var header  = new Header(name, value)
        //    headers.Add(name, new Header(name, value)); 
        //}

        public bool Contains(string name) => this.headers.ContainsKey(name);

        public IEnumerator<Header> GetEnumerator()
            => this.headers.Values.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();

    }
}
