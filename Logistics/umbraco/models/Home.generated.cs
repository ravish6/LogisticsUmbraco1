//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, IAboutUs, IBanner, IWhyChooseUs
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Home(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// homePricingNested
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("homePricingNested")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.PricingPlan> HomePricingNested => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.PricingPlan>>(_publishedValueFallback, "homePricingNested");

		///<summary>
		/// homePricingTitle1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("homePricingTitle1")]
		public virtual string HomePricingTitle1 => this.Value<string>(_publishedValueFallback, "homePricingTitle1");

		///<summary>
		/// homePricingTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("homePricingTitle2")]
		public virtual string HomePricingTitle2 => this.Value<string>(_publishedValueFallback, "homePricingTitle2");

		///<summary>
		/// nestedDeliveryItem
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("nestedDeliveryItem")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.DeliveryTeamNested> NestedDeliveryItem => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.DeliveryTeamNested>>(_publishedValueFallback, "nestedDeliveryItem");

		///<summary>
		/// nestedDeliveryTeamTitle1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("nestedDeliveryTeamTitle1")]
		public virtual string NestedDeliveryTeamTitle1 => this.Value<string>(_publishedValueFallback, "nestedDeliveryTeamTitle1");

		///<summary>
		/// nesteddeliveryTeamTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("nesteddeliveryTeamTitle2")]
		public virtual string NesteddeliveryTeamTitle2 => this.Value<string>(_publishedValueFallback, "nesteddeliveryTeamTitle2");

		///<summary>
		/// nestedTestimonial
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("nestedTestimonial")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.Testimonial> NestedTestimonial => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.Testimonial>>(_publishedValueFallback, "nestedTestimonial");

		///<summary>
		/// ourserviceNested
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourserviceNested")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.OurServices> OurserviceNested => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.OurServices>>(_publishedValueFallback, "ourserviceNested");

		///<summary>
		/// serviceTitle1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceTitle1")]
		public virtual string ServiceTitle1 => this.Value<string>(_publishedValueFallback, "serviceTitle1");

		///<summary>
		/// serviceTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceTitle2")]
		public virtual string ServiceTitle2 => this.Value<string>(_publishedValueFallback, "serviceTitle2");

		///<summary>
		/// testimonialTitle1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("testimonialTitle1")]
		public virtual string TestimonialTitle1 => this.Value<string>(_publishedValueFallback, "testimonialTitle1");

		///<summary>
		/// testimonialTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("testimonialTitle2")]
		public virtual string TestimonialTitle2 => this.Value<string>(_publishedValueFallback, "testimonialTitle2");

		///<summary>
		/// aboutUsDescribe
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsDescribe")]
		public virtual string AboutUsDescribe => global::Umbraco.Cms.Web.Common.PublishedModels.AboutUs.GetAboutUsDescribe(this, _publishedValueFallback);

		///<summary>
		/// aboutUsExperience
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsExperience")]
		public virtual string AboutUsExperience => global::Umbraco.Cms.Web.Common.PublishedModels.AboutUs.GetAboutUsExperience(this, _publishedValueFallback);

		///<summary>
		/// aboutUsImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops AboutUsImage => global::Umbraco.Cms.Web.Common.PublishedModels.AboutUs.GetAboutUsImage(this, _publishedValueFallback);

		///<summary>
		/// aboutUsTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsTitle")]
		public virtual string AboutUsTitle => global::Umbraco.Cms.Web.Common.PublishedModels.AboutUs.GetAboutUsTitle(this, _publishedValueFallback);

		///<summary>
		/// aboutUsTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsTitle2")]
		public virtual string AboutUsTitle2 => global::Umbraco.Cms.Web.Common.PublishedModels.AboutUs.GetAboutUsTitle2(this, _publishedValueFallback);

		///<summary>
		/// bannerImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bannerImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops BannerImage => global::Umbraco.Cms.Web.Common.PublishedModels.Banner.GetBannerImage(this, _publishedValueFallback);

		///<summary>
		/// bannerIsActive: IsActive Used For Active or  DeActivate Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[ImplementPropertyType("bannerIsActive")]
		public virtual bool BannerIsActive => global::Umbraco.Cms.Web.Common.PublishedModels.Banner.GetBannerIsActive(this, _publishedValueFallback);

		///<summary>
		/// bannerSurchTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bannerSurchTitle")]
		public virtual string BannerSurchTitle => global::Umbraco.Cms.Web.Common.PublishedModels.Banner.GetBannerSurchTitle(this, _publishedValueFallback);

		///<summary>
		/// bannerTitle1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bannerTitle1")]
		public virtual string BannerTitle1 => global::Umbraco.Cms.Web.Common.PublishedModels.Banner.GetBannerTitle1(this, _publishedValueFallback);

		///<summary>
		/// bannerTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bannerTitle2")]
		public virtual string BannerTitle2 => global::Umbraco.Cms.Web.Common.PublishedModels.Banner.GetBannerTitle2(this, _publishedValueFallback);

		///<summary>
		/// whyChooseButtonName
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whyChooseButtonName")]
		public virtual string WhyChooseButtonName => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseButtonName(this, _publishedValueFallback);

		///<summary>
		/// whyChooseImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whyChooseImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops WhyChooseImage => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseImage(this, _publishedValueFallback);

		///<summary>
		/// whyChooseUsBenefit1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whyChooseUsBenefit1")]
		public virtual string WhyChooseUsBenefit1 => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseUsBenefit1(this, _publishedValueFallback);

		///<summary>
		/// whyChooseUsBenefit2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whyChooseUsBenefit2")]
		public virtual string WhyChooseUsBenefit2 => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseUsBenefit2(this, _publishedValueFallback);

		///<summary>
		/// whyChooseUsBenefit3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whyChooseUsBenefit3")]
		public virtual string WhyChooseUsBenefit3 => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseUsBenefit3(this, _publishedValueFallback);

		///<summary>
		/// whyChooseUsDescribe
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whyChooseUsDescribe")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString WhyChooseUsDescribe => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseUsDescribe(this, _publishedValueFallback);

		///<summary>
		/// whyChooseUSIsActive
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[ImplementPropertyType("whyChooseUSIsActive")]
		public virtual bool WhyChooseUsisActive => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseUsisActive(this, _publishedValueFallback);

		///<summary>
		/// whyChooseUsTilte2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whyChooseUsTilte2")]
		public virtual string WhyChooseUsTilte2 => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseUsTilte2(this, _publishedValueFallback);

		///<summary>
		/// whyChooseUsTitle1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whyChooseUsTitle1")]
		public virtual string WhyChooseUsTitle1 => global::Umbraco.Cms.Web.Common.PublishedModels.WhyChooseUs.GetWhyChooseUsTitle1(this, _publishedValueFallback);
	}
}
