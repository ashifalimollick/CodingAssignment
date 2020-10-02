using System;
using Xunit;
using PeerIslands_CodingAssignment;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    //Unit test cases for Doctor entity
    public class DoctorUnitTest
    {
        //Test for scenario to read all data 
        [Fact]
        public void Task_Doctor_showData_All()
        {
            //Arrange
            List<DoctorEntity> db = InitialSeed.doctorSeed();

            //Act
            List<DoctorEntity> db1 = DAL.showData(db);

            //Assert
            Assert.Equal(db1, db);
        }
        //Test for scenario when selected data is  present 
        [Fact]
        public void Task_Doctor_showData_Selective_Present()
        {
            //Arrange
            List<DoctorEntity> db = InitialSeed.doctorSeed();

            //Act
            DoctorEntity db1 = DAL.showData(db,1);

            //Assert
            Assert.Equal(db1, db[0]);
        }
        //Test for scenario when selected data is not present 
        [Fact]
        public void Task_Doctor_showData_Selective_NotPresent()
        {
            //Arrange
            List<DoctorEntity> db = InitialSeed.doctorSeed();

            //Act
            DoctorEntity db1 = DAL.showData(db, 2);

            //Assert
            Assert.NotEqual(db1, db[0]);
        }
        //Test for data insertion
        [Fact]
        public void Task_Doctor_insertData()
        {
            //Arrange
            List<DoctorEntity> db = InitialSeed.doctorSeed();
            List<DoctorEntity> db1 = InitialSeed.doctorSeed1();
            DoctorEntity de = InitialSeed.doctorSeed2();

            //Act
            List<DoctorEntity> db2 = DAL.insertData(db, de);

            //Assert
            Assert.NotEqual(db1, db2);
        }
        [Fact]
        //Test for scenario when all data is deleted
        public void Task_Doctor_deleteData_All()
        {
            //Arrange
            List<DoctorEntity> db1 = InitialSeed.doctorSeed1();

            //Act
            List<DoctorEntity> db2 = DAL.deleteData(db1);

            //Assert
            Assert.Empty(db2);
        }
        //Test for scenario when selective data is deleted and row is  present
        [Fact]
        public void Task_Doctor_deleteData_Selective_Present()
        {
            //Arrange
            List<DoctorEntity> db1 = InitialSeed.doctorSeed();
            //Act
            List<DoctorEntity> db2 = DAL.deleteData(db1,1);

            //Assert
            Assert.Empty(db2);
        }
        //Test for scenario when selective data is deleted and row is not present
        [Fact]
        public void Task_Doctor_deleteData_Selective_NotPresent()
        {
            //Arrange
            List<DoctorEntity> db1 = InitialSeed.doctorSeed();
            //Act
            List<DoctorEntity> db2 = DAL.deleteData(db1, 2);

            //Assert
            Assert.NotEmpty(db2);
        }
    }
}
