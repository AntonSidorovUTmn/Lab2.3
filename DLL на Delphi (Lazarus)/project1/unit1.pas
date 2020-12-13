unit Unit1;

{$mode objfpc}{$H+}

interface
function TheFunc(x:double):double; cdecl; external name 'TheFunc';
  function FuncName(): string; cdecl; external name 'TheFunc';


implementation

end.

