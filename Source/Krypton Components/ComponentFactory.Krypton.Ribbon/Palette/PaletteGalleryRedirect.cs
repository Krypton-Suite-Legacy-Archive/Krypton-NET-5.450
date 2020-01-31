﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006 - 2016, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2020. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.450)
//  Version 5.450.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    /// <summary>
    /// Implement storage for a gallery palette redirect. 
    /// </summary>
    public class PaletteGalleryRedirect : PaletteMetricRedirect
    {
        #region Instance Fields
        // Storage
        private readonly PaletteRibbonBack _ribbonBack;
        private readonly PaletteRibbonBack _ribbonBorder;

        // Redirection
        private readonly PaletteRibbonBackInheritRedirect _ribbonBackInherit;
        private readonly PaletteRibbonBackInheritRedirect _ribbonBorderInherit;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteGalleryRedirect class.
        /// </summary>
        /// <param name="redirect">Inheritence redirection instance.</param>
        /// <param name="needPaint">Paint delegate.</param>
        public PaletteGalleryRedirect(PaletteRedirect redirect,
                                      NeedPaintHandler needPaint)
            : base(redirect)
        {
            Debug.Assert(redirect != null);

            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create the redirection instances
            _ribbonBorderInherit = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonGalleryBorder);
            _ribbonBackInherit = new PaletteRibbonBackInheritRedirect(redirect, PaletteRibbonBackStyle.RibbonGalleryBack);

            // Create storage that maps onto the inherit instances
            _ribbonBack = new PaletteRibbonBack(_ribbonBackInherit, needPaint);
            _ribbonBorder = new PaletteRibbonBack(_ribbonBorderInherit, needPaint);
        }
        #endregion

        #region SetRedirector
        /// <summary>
        /// Update the redirector with new reference.
        /// </summary>
        /// <param name="redirect">Target redirector.</param>
        public override void SetRedirector(PaletteRedirect redirect)
        {
            base.SetRedirector(redirect);
            _ribbonBackInherit.SetRedirector(redirect);
            _ribbonBorderInherit.SetRedirector(redirect);
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault => (RibbonGalleryBack.IsDefault &
                                           RibbonGalleryBorder.IsDefault);

        #endregion

        #region RibbonGalleryBack
        /// <summary>
        /// Gets access to the gallery background palette details.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining gallery background appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonGalleryBack => _ribbonBack;

        private bool ShouldSerializeRibbonGalleryBack()
        {
            return !_ribbonBack.IsDefault;
        }
        #endregion

        #region RibbonGalleryBorder
        /// <summary>
        /// Gets access to the gallery border palette details.
        /// </summary>
        [Category("Visuals")]
        [Description("Overrides for defining gallery border appearance.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public virtual PaletteRibbonBack RibbonGalleryBorder => _ribbonBorder;

        private bool ShouldSerializeRibbonGalleryBorder()
        {
            return !_ribbonBorder.IsDefault;
        }
        #endregion

        #region Protected
        /// <summary>
        /// Handle a change event from palette source.
        /// </summary>
        /// <param name="sender">Source of the event.</param>
        /// <param name="needLayout">True if a layout is also needed.</param>
        protected void OnNeedPaint(object sender, bool needLayout)
        {
            // Pass request from child to our own handler
            PerformNeedPaint(needLayout);
        }
        #endregion
    }
}
