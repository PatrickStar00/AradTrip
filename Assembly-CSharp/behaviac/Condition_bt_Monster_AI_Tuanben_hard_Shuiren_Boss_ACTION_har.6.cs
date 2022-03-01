﻿using System;

namespace behaviac
{
	// Token: 0x02003D42 RID: 15682
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_hard_Shuiren_Boss_ACTION_hard_node28 : Condition
	{
		// Token: 0x0601621A RID: 90650 RVA: 0x006B0971 File Offset: 0x006AED71
		public Condition_bt_Monster_AI_Tuanben_hard_Shuiren_Boss_ACTION_hard_node28()
		{
			this.opl_p0 = HMType.HP_PERCENT;
			this.opl_p1 = BE_Operation.LessThanOrEqualTo;
			this.opl_p2 = 0.1f;
		}

		// Token: 0x0601621B RID: 90651 RVA: 0x006B0994 File Offset: 0x006AED94
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHPMP(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FA80 RID: 64128
		private HMType opl_p0;

		// Token: 0x0400FA81 RID: 64129
		private BE_Operation opl_p1;

		// Token: 0x0400FA82 RID: 64130
		private float opl_p2;
	}
}
