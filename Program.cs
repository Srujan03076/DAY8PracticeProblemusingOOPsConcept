using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1_EmpAttendance.EmpAttendance();
            //UC2_EmpWage.EmpWage();
            //UC3_PartTimeEmp.PartTimeEmp();
            //UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            //UC5_WageForMonth.WageForMonth();
            //UC6_WageTillNumOfWorkingDays.WageTillNumOfWorkingDays();
            //UC7_EmpWageUsingClassMethod.EmpWageUsingClassMethod();
            //UC8_EmpWageForMultipleCompanies.computeEmpWage("DMart", 20, 2, 10);
            //UC8_EmpWageForMultipleCompanies.computeEmpWage("Reliance", 10, 4, 20


            //#region for Uc9 Implementation

            //EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            //dMart.computeEmpWage();
            //Console.WriteLine(dMart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());

            //#endregion

            #region for UC10
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            #endregion

            Console.ReadLine();

        }
    }
}
    

