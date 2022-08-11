
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Plexform.Base;
using Plexform.Audit;


namespace LIMS.DTO.SampleLog
{
    #region LVISKADBA.SAMPLE_TXN
    [Table("LVISKADBA.SAMPLE_TXN")]
    public class sampleLog_mstrDTO
    {
		[Key]
		[Required]
		public virtual decimal? ST_SAMPLE_NO { get; set; }
		[Key]
		[MaxLength(40), Required]
		public virtual string ST_LAB_ID { get; set; }
		[Key]
		[MaxLength(60), Required]
		public virtual string ST_SAMPLE_ID { get; set; }
		[Required]
		public virtual decimal? ST_BATCH_NO { get; set; }
		[MaxLength(30)]
		public virtual string ST_STATUS { get; set; }
		[MaxLength(40)]
		public virtual string ST_CLIENT_ID { get; set; }

		public virtual decimal? ST_SPEC_NO { get; set; }

		public virtual decimal? ST_SET { get; set; }

		public virtual decimal? ST_DICTIONARY_NO { get; set; }
		[MaxLength(40)]
		public virtual string ST_INSTRUMENT_ID { get; set; }
		[MaxLength(1000)]
		public virtual string ST_SAMPLE_DESC { get; set; }
		[MaxLength(200)]
		public virtual string ST_SAMPLE_NAME { get; set; }
		[Column(TypeName = "datetime")]
		public virtual System.DateTime? ST_RECEIVED_DT { get; set; }
		[Column(TypeName = "datetime")]
		public virtual System.DateTime? ST_DUE_DT { get; set; }
		[MaxLength(100)]
		public virtual string ST_DATAGROUP_NAME { get; set; }
		[MaxLength(50)]
		public virtual string ST_PO_NO { get; set; }
		[MaxLength(50)]
		public virtual string ST_DO_NO { get; set; }
		[MaxLength(50)]
		public virtual string ST_SHIP_NO { get; set; }

		public virtual decimal? ST_IN_SPECS { get; set; }

		public virtual decimal? ST_OUT_SPECS { get; set; }

		public virtual decimal? ST_EXPERIMENT { get; set; }

		public virtual decimal? ST_CYCLE_DAY { get; set; }
		[MaxLength(50)]
		public virtual string ST_LOCATION { get; set; }
		[MaxLength(200)]
		public virtual string ST_REMARK_LIST { get; set; }
		[MaxLength(50)]
		public virtual string ST_PARAGRAPH_LIST { get; set; }
		[MaxLength(400)]
		public virtual string ST_CANCEL_REASON { get; set; }

		public virtual decimal? ST_TOTAL_PICKUP { get; set; }
		[Column(TypeName = "datetime")]
		public virtual System.DateTime? ST_REPORT_DT { get; set; }
		[MaxLength(40)]
		public virtual string ST_USER_STAMP { get; set; }
		[Column(TypeName = "datetime")]
		public virtual System.DateTime? ST_TIME_STAMP { get; set; }
		[MaxLength(26)]
		public virtual string ST_CN_NO { get; set; }
		[MaxLength(12)]
		public virtual string ST_WASCOD { get; set; }
		[Column(TypeName = "datetime")]
		public virtual System.DateTime? ST_RCVDAT { get; set; }

		public virtual decimal? ST_RCVQTY { get; set; }

		public virtual decimal? ST_RCVQTYTON { get; set; }
		[MaxLength(10)]
		public virtual string ST_PACKCOD { get; set; }
		[MaxLength(100)]
		public virtual string ST_PACKCOD_NAME { get; set; }
		[MaxLength(300)]
		public virtual string ST_WASTE_NAME { get; set; }
		[MaxLength(40)]
		public virtual string ST_WASTYP_CODE { get; set; }
		[MaxLength(60)]
		public virtual string ST_WASTYP_NAME { get; set; }
		[MaxLength(12)]
		public virtual string ST_WASGRP { get; set; }
		[MaxLength(24)]
		public virtual string ST_LSN { get; set; }
		[MaxLength(110)]
		public virtual string ST_COLOR { get; set; }
		[Column(TypeName = "datetime")]
		public virtual System.DateTime? ST_SMPDAT { get; set; }
		[MaxLength(20)]
		public virtual string ST_SMPPNT { get; set; }
		[MaxLength(60)]
		public virtual string ST_CONTAINER { get; set; }
		[MaxLength(60)]
		public virtual string ST_ODOUR { get; set; }
		[MaxLength(510)]
		public virtual string ST_NATURE { get; set; }
		[MaxLength(60)]
		public virtual string ST_SMPTYP { get; set; }
		[MaxLength(40)]
		public virtual string ST_SAMPLER { get; set; }
		[MaxLength(510)]
		public virtual string ST_REMARK { get; set; }
		[MaxLength(20)]
		public virtual string ST_RESAMPLE_VERSION { get; set; }
		[MaxLength(60)]
		public virtual string ST_RESAMPLE_ID { get; set; }
		[MaxLength(10)]
		public virtual string ST_REVIEW_IND { get; set; }
		[MaxLength(26)]
		public virtual string ST_ORGN_CN_NO { get; set; }
		[MaxLength(10)]
		public virtual string ST_FLOW_IND { get; set; }
		[MaxLength(1)]
		public virtual string ST_FINAL_IND { get; set; }
		[MaxLength(1)]
		public virtual string ST_DISPOSE_IND { get; set; }
		[MaxLength(1000)]
		public virtual string ST_REASON { get; set; }
		[MaxLength(100)]
		public virtual string ST_VERIFIED_BY { get; set; }
		[MaxLength(4)]
		public virtual string ST_YEAR { get; set; }
		[MaxLength(1)]
		public virtual string ST_VERIFY_IND { get; set; }
		[MaxLength(20)]
		public virtual string ST_PRIORITY { get; set; }
		[MaxLength(500)]
		public virtual string ST_PROJECTNAME { get; set; }
		[MaxLength(1)]
		public virtual string ST_DICTIONARY_AUTO { get; set; }
		[MaxLength(1)]
		public virtual string ST_IS_SUBMITTED { get; set; }
		[MaxLength(20)]
		public virtual string ST_CN_STATUS { get; set; }
		[MaxLength(100)]
		public virtual string ST_TRANSFERED { get; set; }
		[MaxLength(30)]
		public virtual string ST_SAMPLINGBY { get; set; }
		[MaxLength(30)]
		public virtual string ST_FINAL_DIFF { get; set; }
		[MaxLength(30)]
		public virtual string ST_WASTE_COLOR { get; set; }
		[MaxLength(30)]
		public virtual string ST_COMMENT { get; set; }
		[MaxLength(30)]
		public virtual string ST_PACKCOND { get; set; }
		[MaxLength(30)]
		public virtual string ST_SAMPLER_RECTIME { get; set; }
		[MaxLength(30)]
		public virtual string ST_TOTALLIQUIDEST { get; set; }
		[MaxLength(20)]
		public virtual string ST_SAMPLE_REQUIRED { get; set; }
		[MaxLength(500)]
		public virtual string ST_NCWASTE { get; set; }
		[MaxLength(500)]
		public virtual string ST_NCWASTE_REMARK { get; set; }
	}
	#endregion
}
