﻿using System;

namespace behaviac
{
	// Token: 0x02003D1E RID: 15646
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_hard_Monster_Hongxiaoyurenheti_des_hard_node1 : Condition
	{
		// Token: 0x060161D7 RID: 90583 RVA: 0x006AF98E File Offset: 0x006ADD8E
		public Condition_bt_Monster_AI_Tuanben_hard_Monster_Hongxiaoyurenheti_des_hard_node1()
		{
			this.opl_p0 = 81300011;
			this.opl_p1 = 2;
		}

		// Token: 0x060161D8 RID: 90584 RVA: 0x006AF9A8 File Offset: 0x006ADDA8
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_JudgeMonsterCount(this.opl_p0, this.opl_p1);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400FA5B RID: 64091
		private int opl_p0;

		// Token: 0x0400FA5C RID: 64092
		private int opl_p1;
	}
}
