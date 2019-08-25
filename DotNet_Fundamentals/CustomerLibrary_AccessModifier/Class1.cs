using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary_AccessModifier
{
    public class Customer 
    {
        //So not to make this Validate() complex so that UI Dev can call directly call Add() make it as Private
        //public void Validate()
        //By making Validate(), Private, we are hiding complexity. This is termed as encapsulation.
        //As Validate(), is Private it's only accessible inside class
        private void Validate()
        {
            //Validate
        }

        //By making this protected, whichever classes inherit from this class, they can always access variables, methods
        //which are marked as protected
        protected void Validate1()
        {

        }

        //When internal, it's only accessible in the library, project and assembly in inheritance chain
        internal void Validate2()
        {

        }

        //When protected internal,  inherited classes as well as also classes which are in the same library
        protected internal void Validate3()
        {

        }
        //As Add() is public it's accessible anywhere
        public void Add()
        {
            //Adds it to the DB
            Validate();
        }
    }
    public class Invoice : Customer
    {
        private Customer obj = new Customer();
        public void Validate()
        {
            //obj.Validate();//Not accessible as it's private
            //obj.Validate1();//Cannot be accesses with qualifier of Customer class
            //Validate1();//accessible as it's protected
            Validate3();////Accesible as its protected internal
            obj.Validate3();////Accesible as its protected internal

            obj.Validate2();
            //Validates invoice details

        }
    }



}
