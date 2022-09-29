using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Organizer.Models;
using System;
using System.Linq;

namespace Organizer.TestTools
{
  [TestClass]
	public class RecordTests : IDisposable
	{
		public void Dispose()
		{
			Record.ClearAll();
		}

		[TestMethod]
		public void RecordConstructor_CreatesRecord_True()
		{
      //Assign
			Record record = new Record("Blue Songs", "Blues", 1986);
      //Act
      //Assert
      Assert.AreEqual(typeof(Record), record.GetType());

		}

    [TestMethod]
		public void RecordTitle_ReturnsRecordTitle_String()
		{
      //Assign
			Record record = new Record("Blue Songs", "Blues", 1986);
      //Act
      string result = record.Title;
      //Assert
      Assert.AreEqual("Blue Songs", result);

		}

    [TestMethod]
		public void AccessDiscography_ReturnsDiscography_List()
		{
      //Assign
			Record record1 = new Record("Blue Songs", "Blues", 1986);
			Record record2 = new Record("Red Songs", "Reds", 1990);
			Record record3 = new Record("Green Songs", "Greens", 1999);

      List<Record> test = Record.GetRecords();

      int result = test[2].Year;

      //Assert
      Assert.AreEqual(1999, result);

		}

    [TestMethod]
		public void AccessID_ReturnsID_Int()
		{
      //Assign
			Record record1 = new Record("Blue Songs", "Blues", 1986);
			Record record2 = new Record("Red Songs", "Reds", 1990);
			Record record3 = new Record("Green Songs", "Greens", 1999);

      Record test = Record.FindRecord(2);
      int result = test.Id;

      //Assert
      Assert.AreEqual(2, result);

		}

	}
}