using System;
using Xunit;
using PeerIslands_CodingAssignment;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    //Unit test cases for Patient entity
    public class PatientUnitTest
    {
        //Test to check whether all data being read or not
        [Fact]
        public void Task_Patient_showData_All()
        {
            //Arrange
            List<PatientEntity> db = InitialSeed.patientSeed();

            //Act
            List<PatientEntity> db1 = DAL.showData(db);

            //Assert
            Assert.Equal(db1, db);
        }

        //Test for scenario when selected data is present 
        [Fact]
        public void Task_Patient_showData_Selective_Present()
        {
            //Arrange
            List<PatientEntity> db = InitialSeed.patientSeed();

            //Act
            PatientEntity db1 = DAL.showData(db,1);

            //Assert
            Assert.Equal(db1, db[0]);
        }

        //Test for scenario when selected data is not present 
        [Fact]
        public void Task_Patient_showData_Selective_NotPresent()
        {
            //Arrange
            List<PatientEntity> db = InitialSeed.patientSeed();

            //Act
            PatientEntity db1 = DAL.showData(db, 2);

            //Assert
            Assert.NotEqual(db1, db[0]);
        }
        [Fact]
        //Test for data insertion
        public void Task_Patient_insertData()
        {
            //Arrange
            List<PatientEntity> db = InitialSeed.patientSeed();
            List<PatientEntity> db1 = InitialSeed.patientSeed1();
            PatientEntity de = InitialSeed.patientSeed2();

            //Act
            List<PatientEntity> db2 = DAL.insertData(db, de);

            //Assert
            Assert.NotEqual(db1, db2);
        }
        //Test for scenario where all data is deleted
        [Fact]
        public void Task_Patient_deleteData_All()
        {
            //Arrange
            List<PatientEntity> db1 = InitialSeed.patientSeed();

            //Act
            List<PatientEntity> db2 = DAL.deleteData(db1);

            //Assert
            Assert.Empty(db2);
        }
        //Test for scenario when selective data is deleted and row is present 
        [Fact]
        public void Task_Patient_deleteData_Selective_Present()
        {
            //Arrange
            List<PatientEntity> db1 = InitialSeed.patientSeed();
            //Act
            List<PatientEntity> db2 = DAL.deleteData(db1,1);

            //Assert
            Assert.Empty(db2);
        }
        //Test for scenario when selective data is deleted and row is not present
        [Fact]
        public void Task_Patient_deleteData_Selective_NotPresent()
        {
            //Arrange
            List<PatientEntity> db1 = InitialSeed.patientSeed();
            //Act
            List<PatientEntity> db2 = DAL.deleteData(db1, 2);

            //Assert
            Assert.NotEmpty(db2);
        }
    }
}
