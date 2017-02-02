using System;
namespace Inserter
{
 abstract class B:A
    {
		public override int Delete(int i)
		{
			return --i;
		}
	}
	
}