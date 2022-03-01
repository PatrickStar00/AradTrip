﻿using System;

namespace behaviac
{
	// Token: 0x02001DF2 RID: 7666
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_APC_APC_Nianqishi_Action_DestinationSelect_node2 : Condition
	{
		// Token: 0x06012599 RID: 75161 RVA: 0x0055C05F File Offset: 0x0055A45F
		public Condition_bt_APC_APC_Nianqishi_Action_DestinationSelect_node2()
		{
			this.opl_p0 = BE_Target.Enemy;
			this.opl_p1 = BE_Equal.Equal;
			this.opl_p2 = BE_State.DAODI;
		}

		// Token: 0x0601259A RID: 75162 RVA: 0x0055C07C File Offset: 0x0055A47C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckState(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400BF8E RID: 49038
		private BE_Target opl_p0;

		// Token: 0x0400BF8F RID: 49039
		private BE_Equal opl_p1;

		// Token: 0x0400BF90 RID: 49040
		private BE_State opl_p2;
	}
}
