﻿using System;

namespace behaviac
{
	// Token: 0x020038C2 RID: 14530
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Event_Hard_node13 : Condition
	{
		// Token: 0x06015963 RID: 88419 RVA: 0x0068404D File Offset: 0x0068244D
		public Condition_bt_Monster_AI_Tuanben_Chap_3_Emeng_BOSS_Kexila_Event_Hard_node13()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 521632;
		}

		// Token: 0x06015964 RID: 88420 RVA: 0x00684070 File Offset: 0x00682470
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F30D RID: 62221
		private BE_Target opl_p0;

		// Token: 0x0400F30E RID: 62222
		private BE_Equal opl_p1;

		// Token: 0x0400F30F RID: 62223
		private int opl_p2;
	}
}
