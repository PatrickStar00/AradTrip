﻿using System;

namespace behaviac
{
	// Token: 0x02001D69 RID: 7529
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_APC_APC_jiqingjieshuoyuan_Action_node11 : Condition
	{
		// Token: 0x0601248F RID: 74895 RVA: 0x00555B1B File Offset: 0x00553F1B
		public Condition_bt_APC_APC_jiqingjieshuoyuan_Action_node11()
		{
			this.opl_p0 = 8008;
		}

		// Token: 0x06012490 RID: 74896 RVA: 0x00555B30 File Offset: 0x00553F30
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400BE7F RID: 48767
		private int opl_p0;
	}
}
