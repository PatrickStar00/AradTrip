﻿using System;

namespace behaviac
{
	// Token: 0x02003F6A RID: 16234
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Zhanguoyuangu_zhanguoyuangu_jingying4_node3 : Condition
	{
		// Token: 0x06016641 RID: 91713 RVA: 0x006C60C0 File Offset: 0x006C44C0
		public Condition_bt_Monster_AI_Zhanguoyuangu_zhanguoyuangu_jingying4_node3()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.NotEqual;
			this.opl_p2 = 570217;
		}

		// Token: 0x06016642 RID: 91714 RVA: 0x006C60E4 File Offset: 0x006C44E4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FE8B RID: 65163
		private BE_Target opl_p0;

		// Token: 0x0400FE8C RID: 65164
		private BE_Equal opl_p1;

		// Token: 0x0400FE8D RID: 65165
		private int opl_p2;
	}
}
