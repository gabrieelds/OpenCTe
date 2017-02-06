using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenCTe.Classes {
    class Connection {
        string[] urls = { "http://trucker.opentechgr.com.br/Buturi/Producao", "http://trucker1.opentechgr.com.br/Buturi/Producao", "http://trucker2.opentechgr.com.br/Buturi/Producao" };
        //string[] urls = { "http://trucker.opentechgr.com.br/asdasd/Producao", "http://trucker1.opentechgr.com.br/dasda/Producao", "http://trucker2.opentechgr.com.br/dasdasdasd/Producao" };
        
        public string tryConn(){
            foreach(string u in this.urls){
                if(this.checkURL(u)){
                    return u;
                }
            }
            return "---";
        }

        private bool checkURL(string url) {
            try {
                Uri urlCheck = new Uri(url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlCheck);
                HttpWebResponse response;
                response = (HttpWebResponse)request.GetResponse();
                return true;
            } catch (Exception){
                return false;
            }

        }
    }
}