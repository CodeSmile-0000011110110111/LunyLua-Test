using Lua;
using NUnit.Framework;
using System;

namespace LunyLua.Test
{
	[TestFixture]
	public class LuaValueTests
	{
		[Test]
		public void TestLuaValueBasicUsage()
		{
			// LuaValue can be created from primitives.
			var val = (LuaValue)123.45;
			Assert.That(val.Type, Is.EqualTo(LuaValueType.Number));
			Assert.That(val.ToString(), Is.EqualTo("123.45"));
			Assert.That(val.Read<Double>(), Is.EqualTo(123.45));

			var strVal = (LuaValue)"Hello Lua";
			Assert.That(strVal.Type, Is.EqualTo(LuaValueType.String));
			Assert.That(strVal.ToString(), Is.EqualTo("Hello Lua"));
			Assert.That(strVal.Read<String>(), Is.EqualTo("Hello Lua"));
		}
	}
}
