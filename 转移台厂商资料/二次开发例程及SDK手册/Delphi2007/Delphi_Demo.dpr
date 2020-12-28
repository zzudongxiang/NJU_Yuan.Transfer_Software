program Delphi_Demo;

uses
  Forms,
  main in 'main.pas' {MainFrm},
  MT_API in 'MT_API.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TMainFrm, MainFrm);
  Application.Run;
end.
