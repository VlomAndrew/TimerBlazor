namespace WebClient.Shared.Models
{
    public class CreateBossModel : BossBaseModel
    {
        public byte[] LogoImage { get; set; }

        public ServerMovel Server { get; set; }

        public HistoryModel HistoryAction { get; set; }
    }
}