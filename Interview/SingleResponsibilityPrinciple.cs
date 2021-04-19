using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SingleResponsibilityPrinciple
{/*
  * Single Resposibility Principle
  * A class should have only one reason to  change.
  * Every module or class should have as reposibility  over a single  part of the fnctionality provided by software,
    and that responsibity should be entirely encapulated by the class.
  * Motivation
     >  Maintainablity
     >  Testability.
     >  Flexibility and Extensibility
     >  Parallel Development
     >  Loose Coupling
     >  SOLID Principles and De
  *  Each class and module should focus on a single task at a time. 
  *  Everything in the class should be related to that single purpose.
  *  There can be many members in the class as long as they related to the single resposibility.
  * 
    */
    public   class SingleResponsibilityPrinciple
    {

    }

    interface IUser
    {
        bool  Login(string username, string password);
        bool Registration(string username, string password, string email);
        
    }

    interface ILogger
    {
        void LogError(string error);
    }
    interface IEmail
    {
        void SendEmail(string emailContent);
    }
}
