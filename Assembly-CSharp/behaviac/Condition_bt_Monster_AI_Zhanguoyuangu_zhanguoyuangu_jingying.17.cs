﻿using System;

namespace behaviac
{
	// Token: 0x02003F61 RID: 16225
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Zhanguoyuangu_zhanguoyuangu_jingying3_node8 : Condition
	{
		// Token: 0x06016630 RID: 91696 RVA: 0x006C5A33 File Offset: 0x006C3E33
		public Condition_bt_Monster_AI_Zhanguoyuangu_zhanguoyuangu_jingying3_node8()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.NotEqual;
			this.opl_p2 = 570231;
		}

		// Token: 0x06016631 RID: 91697 RVA: 0x006C5A54 File Offset: 0x006C3E54
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FE71 RID: 65137
		private BE_Target opl_p0;

		// Token: 0x0400FE72 RID: 65138
		private BE_Equal opl_p1;

		// Token: 0x0400FE73 RID: 65139
		private int opl_p2;
	}
}
