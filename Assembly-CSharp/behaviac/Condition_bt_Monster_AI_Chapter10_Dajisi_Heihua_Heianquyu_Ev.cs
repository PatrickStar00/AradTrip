﻿using System;

namespace behaviac
{
	// Token: 0x020030DA RID: 12506
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Chapter10_Dajisi_Heihua_Heianquyu_Event_node3 : Condition
	{
		// Token: 0x06014A6A RID: 84586 RVA: 0x0063801A File Offset: 0x0063641A
		public Condition_bt_Monster_AI_Chapter10_Dajisi_Heihua_Heianquyu_Event_node3()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = 522995;
		}

		// Token: 0x06014A6B RID: 84587 RVA: 0x0063803C File Offset: 0x0063643C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400E3D2 RID: 58322
		private BE_Target opl_p0;

		// Token: 0x0400E3D3 RID: 58323
		private BE_Equal opl_p1;

		// Token: 0x0400E3D4 RID: 58324
		private int opl_p2;
	}
}
