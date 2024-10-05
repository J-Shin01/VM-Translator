using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 .vm파일구문 분석을 처리하고, 입력 코드에 대한 접근을 캡슐화한다.
 VM 명령을 읽어서 분석하고, 각 구성 성분에 편리하게 접근할 수 있게 한다.
 추가로 공백과 주석을 모두 제거한다.
 
 */



namespace VMtranslator
{   


    partial class Parser
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

        public Parser(StreamReader file) {
            //입력 파일/스트림을 열고 분석할 준비를 한다.
        
        }
        public Boolean hasMoreCommands() {
            //입력에 명령이 더 있는가?

            return false;
        }
        public void advance() { 
            //입력에서 다음 명령을 읽고 현재 명령으로 만든다.
            //hasMore Commands()가 참일 때만 호출되어야ㅎ 한다. 초기에는 현재 명령은 비어 있다.

        
        }
        public int commandType() {
            //현재 VM 명령의 타입을 반환한다. 모든 산술명령에 대해 C_ARITHMETIC이 반환된다.
            /*
                C_ARITHMETIC = 1;
                C_PUSH = 2;
                C_POP = 3;
                C_LABEL = 4;
                C_GOTO = 5;
                C_IF = 6;
                C_FUNCTION = 7;
                C_RETURN = 8;
                C_CALL = 9;
             */


            return -1;
        }
        public string arg1() {
            //현재 명령의 첫 인수를 반환한다. 
            //C_ARITHMETIC의 경우에는 명령 그 자체(add, sub등)가 반환된다.
            //현재 명령이 C_RETURN이면 호출되면 안 된다.


            return "Not Yet";
        }
        public int arg2() {
            //g현재 명령의 두 번쨰 인수를 반환한다. 
            //현재 명령이 C_PUSH : 2, C_POP : 3, C_FUNCTION : 7 또는 C_CALL : 9일 떄만 호출되어야 한다.

            return -1;
        }

        //Project 8에서 더 많은 루틴이 추가된다.
    }
}
