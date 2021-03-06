using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pwStore.Model;

namespace pwStore.Model
{
    abstract class PassGen
    {
        private int MakeType;     //App Property : Password Make format : Algorithm Modifier
        private string ranData;   //Any name related to the user
        private string ranNum;    //A random number selected by the user
        private string ranWord;   //Any Random Word
        private string intensity; //App Property : String OR Medium OR Light
        private string platform;  //Type of platform the password is intended to use
        private string password;  //The Password

        public string Password
        {
            get 
            {
                var encKey = "b14ca5898a4e4133bbce2ea2315a1916";
                return  AesOperation.DecryptString(encKey, password); 

            }

            set 
            {
                var encKey = "b14ca5898a4e4133bbce2ea2315a1916";
                password = AesOperation.EncryptString(encKey, Password);
            }
        }
         

 

    }
}
