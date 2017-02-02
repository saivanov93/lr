using System;
namespace Inserter
{
abstract class C:A
    {
		public override int Add(int i)
		{
			return ++i;
		}
	}
	
}