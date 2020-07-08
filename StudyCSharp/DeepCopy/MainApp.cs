using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        // 깊은 복사를 하기 위한 함수
        public MyClass DeepCopy()
        {
            MyClass newcopy = new MyClass
            {
                MyField1 = this.MyField1,
                MyField2 = this.MyField2
            };
            return newcopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            // 얕은 복사 
            Console.WriteLine("Shallow Copy");
            //구분 코드블럭
            {
                MyClass source = new MyClass
                {
                    MyField1 = 10,
                    MyField2 = 20
                };

                MyClass target = source;                                        // source 복사
                target.MyField2 = 300;                                          // 복사한 값 변경

                // 클래스는 항상 주소를 참조 하므로 얕은 복사를 하게 되면 복사한 클래스도 같은 주소를 가리키게 된다          
                // 그러므로 복사한 값을 변경했지만 원래 값도 같이 변경이 된다
                Console.WriteLine($"{source.MyField1} : {source.MyField2}");    // 10 : 300
                Console.WriteLine($"{target.MyField1} : {target.MyField2}");    // 10 : 300
            }

            // 깊은 복사
            Console.WriteLine("Deep Copy"); 
            {
                MyClass source = new MyClass
                {
                    MyField1 = 10,
                    MyField2 = 20
                };

                // 위에서 생성한 깊은 복사 함수를 사용
                MyClass target = source.DeepCopy();    
                target.MyField2 = 300;

                // 별도의 공간에 값을 복사하므로 복사한 값을 변경해도 원래 값은 변경되지 않는다.
                Console.WriteLine($"{source.MyField1} : {source.MyField2}");    // 10 : 20
                Console.WriteLine($"{target.MyField1} : {target.MyField2}");    // 10 : 300
            }
        }
    }
}