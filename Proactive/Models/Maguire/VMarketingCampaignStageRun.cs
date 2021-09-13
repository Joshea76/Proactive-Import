using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VMarketingCampaignStageRun
    {
        public Guid McsrId { get; set; }
        public Guid StgId { get; set; }
        public byte? RunState { get; set; }
        public DateTime? RunDate { get; set; }
        public string RunBy { get; set; }
        public DateTime? RunStart { get; set; }
        public DateTime? RunEnd { get; set; }
        public byte? ActCreate { get; set; }
        public DateTime? ActStartDate { get; set; }
        public DateTime? ActDueDate { get; set; }
        public Guid? ActOwner { get; set; }
        public bool? ActAcManager { get; set; }
        public Guid? ActStage { get; set; }
        public string DefaultSalutation { get; set; }
        public string DefaultRecipient { get; set; }
        public int CTotal { get; set; }
        public int CValid { get; set; }
        public int CSent { get; set; }
        public int CTltAppointments { get; set; }
        public int CUnqAppointments { get; set; }
        public int CCompleteAppointments { get; set; }
        public int CTltEmailsOpened { get; set; }
        public int CTltEmailsClicked { get; set; }
        public int CTltEmailsDelivered { get; set; }
        public int CTltEmailsReplied { get; set; }
        public int CTltEmailsBounced { get; set; }
        public int CTltEmailsUnsubthis { get; set; }
        public int CTltEmailsUnsuball { get; set; }
        public int CUnqEmailsOpened { get; set; }
        public int CUnqEmailsClicked { get; set; }
        public int CUnqEmailsDelivered { get; set; }
        public int CUnqEmailsReplied { get; set; }
        public int CUnqEmailsBounced { get; set; }
        public int CUnqEmailsUnsubthis { get; set; }
        public int CUnqEmailsUnsuball { get; set; }
        public Guid? UsId { get; set; }
        public bool? NewOnly { get; set; }
        public bool IsAutomated { get; set; }
        public DateTime? StartTime { get; set; }
        public string DeletedBy { get; set; }
        public bool? McsrDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool DocumentLetterJobCreated { get; set; }
    }
}
