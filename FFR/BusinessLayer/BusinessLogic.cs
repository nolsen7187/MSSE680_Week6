using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using System.Collections;
using System.Xml;
using DAL;

namespace BusinessLayer
{
    public class Facade
    {
        private InstatiateCallerRequested instatiateCallerRequested = new InstatiateCallerRequested();
        private HandleData handleData = new HandleData();
        private PerformAction performAction = new PerformAction();
        private Customer lclClass;
        private int lclActionType;

        public Facade(Customer Class, int ActionType)
        {
            this.lclClass = Class;
            this.lclActionType = ActionType;
        }
        public void ProcessRequest()
        {
            //instatiateCallerRequested.InstantiateCallerRequested(localXmlWriter, localxmlFileName);
            //handleData.setdata(localXmlWriter, localxmlFileName);
            performAction.Action(lclClass, lclActionType);

            //this.localXmlWriter.Dispose();
            //this.localxmlFileName = "";
                
        }
    }
}
