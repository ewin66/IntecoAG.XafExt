using DevExpress.ExpressApp.Security;

namespace IntecoAG.XAFExt.StateMachine {
    public class StateMachineTransitionRequestProcessor : PermissionRequestProcessorBase<StateMachineTransitionOperationRequest> {

        protected override bool IsRequestFit(StateMachineTransitionOperationRequest permissionRequest, OperationPermissionBase permission, IRequestSecurityStrategy securityInstance) {
            if (permission is StateMachineTransitionPermission) {
                return permissionRequest.Modifier == ((StateMachineTransitionPermission)permission).Modifier &&
                       permissionRequest.StateCaption == ((StateMachineTransitionPermission)permission).StateCaption &&
                       permissionRequest.StateMachineName == ((StateMachineTransitionPermission)permission).StateMachineName;
            }
            return false;
        }

    }
}