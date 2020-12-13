library project1;

uses
  Classes;

function TheFunc(x: double): double; cdecl;

Begin
  TheFunc := x*x*x/21;
END;

function FuncName: string; cdecl;

Begin
  FuncName := 'x^3/21';
END;

Exports
TheFunc index 1 name 'TheFunc',
FuncName index 2 name 'FuncName';

begin
end.

