using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_Association_Aggregation_Composition
{
    public class Manager
    {
        public Project oProject;
        public Manager()
        {
            oProject = new Project(this);
        }
        //Aggregation
        public List<Worker> Workers = new List<Worker>();//As worker can only belong to Manager
        public void Logon(SwipeCard obj)
        {
            obj.Swipe(this);
        }
        public string GetManagerName()
        {
            return "Manish";
        }
        public double Salary;
        public void HowIsTheManager(bool Good)
        {
            if(Good)
            {
                oProject.IssSuccess = true;
            }
            else
            {
                oProject.IssSuccess = false;
            }
        }
    }
    public class SwipeCard
    {
        public void Swipe(Manager obj)
        {
            //goes and swipes the manager
        }
        public string MakeofSwipe()
        {
            return "m0002";
        }
    }
    public class Worker
    {
        public string WorkerName = "";
    }
    public class Project
    {
        private Manager oManager;
        private bool IsSuccess = false;
        public bool IssSuccess
        {
            get { return IsSuccess; }
            set
            {
                IsSuccess = value;
                if(value)
                {
                    oManager.Salary++;
                }
                else
                {
                    oManager.Salary--;
                }
            }
        }
        public Project(Manager obj)
        {
            oManager = obj;
        }
    }
}
