using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace VMtranslator
{   /*                                      Plan
     메인 프로그램은 VM 입력 파일을 분석하기 위한 Parser와 출력 파일에 코드를 기록하기 위한 CodeWriter를 생성해야한다.
    그런 다음 입력 파일의 VM 명령들을 차례대로 훑으며 각 명령에 대한 어셈블리 코드를 만들어야 한다.
    프로그램 인수가 파일명이 아닌 디렉터리명일 경우에는,
    메인 프로그램은 디렉터리 내의 모든 .vm 파일을 처리해야 한다.
    그렇게 하려면 각각의 입력 파일을 처리하는 Parser 여러 개와, 출력을 처리하는 CodeWriter가 하나 있어야한다.
     */
    
    /*
                                구현 가이드라인
    1). 스택 산술 명령
        ( 9개의 산술 및 논리 명령/ push constant x 명령 ) 구현 먼저 해라.

    2). 메모리 접근 명령 
        8개의 메모리 세그먼트를 처리하는 push/pop 명령 구현 
	    -(0). constant 세그먼트는 이미 처리 가능.
	    -(1). local, argument, this, that 세그먼트 처리 기능
	    -(2). pointer, temp 세그먼트 처리 기능. 
	    	: this, that 세그먼트의 시작 주소를 변경할 수 있게 한다.
	    -(3). static 세그먼트를 처리하는 기능 넣는다.
     */
    class Program
    {
        private int C_ARITHMETIC = 1;
        private int C_PUSH = 2;
        private int C_POP = 3;
        private int C_LABEL = 4;
        private int C_GOTO = 5;
        private int C_IF = 6;
        private int C_FUNCTION = 7;
        private int C_RETURN = 8;
        private int C_CALL = 9;

        static void Main(string[] args)
        {
        }
    }
}
