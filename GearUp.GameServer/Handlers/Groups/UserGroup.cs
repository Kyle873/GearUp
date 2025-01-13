using GearUp.Common.Protocol;

namespace GearUp.GameServer.Handlers.Groups
{
    public class UserGroup : OperationHandlerBase
    {
        [OperationHandler(OperationCode.Ping)]
        public static ResponseOperation HandlePing(RequestOperation req, UserContext _)
        {
            var res = CreateResponse(req);

            res.ReturnCache.Add(DataTypes.ProtoPang, [new ProtoPang
            {
                UserId = req.UserId,
                ServerTime = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                DelaySeconds = 25,
                Timezone = 7
            }]);

            return res;
        }

        [OperationHandler(OperationCode.SetPlayerNickName)]
        public static ResponseOperation HandleSetPlayerNickName(RequestOperation req, UserContext ctx)
        {
            var res = CreateResponse(req);

            ctx.SetPlayerNickName(req.Str_1);
            res.ReturnCache.Add(DataTypes.ProtoPlayer, [ctx.RequiredPlayer]);
            ctx.DataStore.Save();

            return res;
        }

        [OperationHandler(OperationCode.Login)]
        public static ResponseOperation HandleLogin(RequestOperation req, UserContext ctx)
        {
            var res = CreateResponse(req);

            var player = ctx.Player ?? ctx.CreateNewPlayer();
            res.ReturnCache.Add(DataTypes.ProtoPlayer, [player]);
            res.ReturnCache.Add(DataTypes.ProtoGirl, [..ctx.PlayerGirls]);
            ctx.DataStore.Save();

            return res;
        }
    }
}
