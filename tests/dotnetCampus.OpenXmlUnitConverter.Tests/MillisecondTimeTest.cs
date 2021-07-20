using System;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest.Extensions.Contracts;

namespace dotnetCampus.OpenXmlUnitConverter.Tests
{
    [TestClass]
    public class MillisecondTimeTest
    {
        [ContractTestCase]
        public void FromMilliseconds()
        {
            "�ṩ�Ӻ��봴���ķ��������ԴӸ����ĺ�����д��� MillisecondTime �ṹ��".Test(() =>
            {
                var milliseconds = 300;
                var millisecondTime = MillisecondTime.FromMilliseconds(milliseconds);
                Assert.AreEqual(TimeSpan.FromMilliseconds(milliseconds), millisecondTime.ToTimeSpan());
            });
        }

        [ContractTestCase]
        public void ParseMillisecondTimeText()
        {
            "���� null �� OpenXML �ַ���������˵��δ����".Test(() =>
            {
                StringValue stringValue = null!;
                var millisecondTime = new MillisecondTime(stringValue);
                Assert.AreEqual(true, millisecondTime.IsIndefinite);
            });

            "����δ����� OpenXML �ַ���������˵��δ����".Test(() =>
            {
                var stringValue = new StringValue(IndefiniteTimeDeclarationValues.Indefinite.ToString());
                var millisecondTime = new MillisecondTime(stringValue);
                Assert.AreEqual(true, millisecondTime.IsIndefinite);
            });

            "������ֵ��ʾ�ĺ���ʱ��� OpenXML �ַ��������Խ���������ʱ��".Test(() =>
            {
                var n = 123;
                var stringValue = new StringValue(n.ToString());
                var millisecondTime = new MillisecondTime(stringValue);
                Assert.AreEqual(n, millisecondTime.Milliseconds);
                Assert.AreEqual(1230000, millisecondTime.ToTicks());
                Assert.AreEqual(TimeSpan.FromMilliseconds(n), millisecondTime.ToTimeSpan());
            });
        }
    }
}