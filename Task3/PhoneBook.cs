using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal class PhoneBook :IEnumerable<KeyValuePair<string,string>>
    {
        private Dictionary<string, string> pBook;
        public PhoneBook() => pBook = new();

        public bool Get(string? name, out string? phone) => pBook.TryGetValue(name ?? "", out phone);

        public void AddReplace(string? name,string? phone)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ) throw new ApplicationException(" Name or phone number cannot be empty in \"AddReplace\" methode ");
            if (!Regex.IsMatch(phone, @"^\+\d{2}\(\d{3}\)\d{3}-\d{2}-\d{2}$")) throw new ApplicationException(" Invalid phone format ... must be \" \"+38(xxx)xxx-xx-xx\"\"");
            if (!Regex.IsMatch(name, @"[А-ЯA-ZІЇЄ][а-яa-zіїє]{1,20}\s[А-ЯA-ZІЇЄ]\.[А-ЯA-ZІЇЄ]\.")) throw new ApplicationException(" Invalid name format ... must be \" Xx(1-20) X.X.\"");
            pBook[name] = phone;
        }

        public bool Del(string? name) => pBook.Remove(name ?? "");

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, string>>)pBook).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)pBook).GetEnumerator();
        }
    }
}
