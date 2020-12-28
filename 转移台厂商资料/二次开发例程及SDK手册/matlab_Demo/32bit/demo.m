% step 1 :  mex -setup  select c compiler 
% step 2:   install activeperl if there not installed
% stpe 3:   use MT_API.dll and MT_API.h

%load dll only onetime
if not(libisloaded('MT_API'))
    loadlibrary('MT_API.dll','MT_API.h');
end
ir=0;

% get resource memory and so from windows,only once
calllib('MT_API','MT_Init');
calllib('MT_API','MT_Close_UART');
calllib('MT_API','MT_Close_USB');

% open communication port
calllib('MT_API','MT_Open_USB')

% if use serial comport call this

%calllib('MT_API','MT_Open_UART','COM7');
  
% check communitcation
ir=calllib('MT_API','MT_Check');
if(ir~=0)
  return;
end
% example1:  enter home mode to find zero switch  
% if no need to find home position, comment example1
calllib('MT_API','MT_Set_Axis_Mode_Home_Home_Switch',0);

% home mode params acc dec
calllib('MT_API','MT_Set_Axis_Home_Acc',0,2000);
calllib('MT_API','MT_Set_Axis_Home_Dec',0,2000);
% start home to the negative direction
calllib('MT_API','MT_Set_Axis_Home_V',0,-2000);

% wait home_switch is reached
iRun=0;

iPos=0;
while(1>0)
   pause(0.1); 
   [ir,iPos]=calllib('MT_API','MT_Get_Axis_Software_P_Now',0,iPos);
   iPos
   [ir,iRun]=calllib('MT_API','MT_Get_Axis_Status_Run',0,iRun);
   if(iRun==0)
       break;
   end
end

% example2:  enter velocity mode to turn motor with const velocity for 5 senconds  

calllib('MT_API','MT_Set_Axis_Mode_Velocity',0);

% home mode params acc dec
calllib('MT_API','MT_Set_Axis_Velocity_Acc',0,2000);
calllib('MT_API','MT_Set_Axis_Velocity_Dec',0,2000);
% start the motor 
calllib('MT_API','MT_Set_Axis_Velocity_V_Target_Abs',0,5000);

% wait 5 senconds
pause(5);
% stop
calllib('MT_API','MT_Set_Axis_Velocity_Stop',0);

% wait stop
while(1>0)
   pause(0.1); 
   [ir,iPos]=calllib('MT_API','MT_Get_Axis_Software_P_Now',0,iPos);
   iPos
   [ir,iRun]=calllib('MT_API','MT_Get_Axis_Status_Run',0,iRun);
   if(iRun==0)
       break;
   end
end


% example3:  enter Positon mode  loop 3 times for constant length  

calllib('MT_API','MT_Set_Axis_Mode_Position',0);

% home mode params acc dec
calllib('MT_API','MT_Set_Axis_Position_Acc',0,2000);
calllib('MT_API','MT_Set_Axis_Position_Dec',0,2000);
calllib('MT_API','MT_Set_Axis_Position_V_Max',0,5000);

% wait home_switch is reached
iCount=0;
while(iCount<3)
  % positive   move  100000 steps from current position positive direction
    calllib('MT_API','MT_Set_Axis_Position_P_Target_Rel',0,100000);
  % wait complete
    iRun=0;
    ir=0;
    while(1>0)
       pause(0.1); 
       % read the position now
       [ir,iPos]=calllib('MT_API','MT_Get_Axis_Software_P_Now',0,iPos);
       iPos
       [ir,iRun]=calllib('MT_API','MT_Get_Axis_Status_Run',0,iRun);
       if(iRun==0)
           break;
       end
    end     
  % negtive   move  100000 steps from current position negtive direction
  % back to the start
    calllib('MT_API','MT_Set_Axis_Position_P_Target_Rel',0,-100000);
  % wait complete
    iRun=0;
    ir=0;
    while(1>0)
       pause(0.1); 
       % read the position now
       [ir,iPos]=calllib('MT_API','MT_Get_Axis_Software_P_Now',0,iPos);
       iPos
       [ir,iRun]=calllib('MT_API','MT_Get_Axis_Status_Run',0,iRun);
       if(iRun==0)
           break;
       end
    end     
   iCount=iCount+1; 
end

% back to zero positon
calllib('MT_API','MT_Set_Axis_Position_P_Target_Abs',0,0);
  % wait complete
    iRun=0;
    ir=0;
    while(1>0)
       pause(0.1); 
       % read the position now
       [ir,iPos]=calllib('MT_API','MT_Get_Axis_Software_P_Now',0,iPos);
       iPos
       [ir,iRun]=calllib('MT_API','MT_Get_Axis_Status_Run',0,iRun);
       if(iRun==0)
           break;
       end
    end 
 
    
    % end the demo
 calllib('MT_API','MT_Close_UART');
 calllib('MT_API','MT_Close_USB');
 calllib('MT_API','MT_DeInit');
 unloadlibrary('MT_API');
 disp('Demo ended')


    




