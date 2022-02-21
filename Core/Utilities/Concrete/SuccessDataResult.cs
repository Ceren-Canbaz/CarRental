using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
	public class SuccessDataResult<T>:DataResult<T>
	{
		public SuccessDataResult(T data,string message):base(data,true,message)
		{
			// DataResulta gidiyor. 
			//data mesaj ve basarili olduguna dair bilgiler istendiginde calisacak olan constructor
		}
		public SuccessDataResult(T data):base(data,true)
		{

		}
		public SuccessDataResult(string message) : base(default, true, message)
		{

		}
		public SuccessDataResult() : base(default, true)
		{

		}
	}
}
