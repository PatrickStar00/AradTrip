﻿using System;

namespace behaviac
{
	// Token: 0x020038B8 RID: 14520
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Event_Hard_node70 : Condition
	{
		// Token: 0x0601594F RID: 88399 RVA: 0x00683D6F File Offset: 0x0068216F
		public Condition_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Event_Hard_node70()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 570215;
		}

		// Token: 0x06015950 RID: 88400 RVA: 0x00683D90 File Offset: 0x00682190
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F2F7 RID: 62199
		private BE_Target opl_p0;

		// Token: 0x0400F2F8 RID: 62200
		private BE_Equal opl_p1;

		// Token: 0x0400F2F9 RID: 62201
		private int opl_p2;
	}
}
