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

using System.Drawing;
using System.ComponentModel;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Storage for context menu images.
    /// </summary>
    public class ContextMenuImages : Storage
    {
        #region Instance Fields
        private Image _checked;
        private Image _indeterminate;
        private Image _subMenu;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the ContextMenuImages class.
        /// </summary>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public ContextMenuImages(NeedPaintHandler needPaint) 
        {
            // Store the provided paint notification delegate
            NeedPaint = needPaint;

            // Create the storage
            _checked = null;
            _indeterminate = null;
            _subMenu = null;
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault => (_checked == null) &&
                                          (_indeterminate == null) &&
                                          (_subMenu == null);

        #endregion

        #region Checked
        /// <summary>
        /// Gets and sets the image for a checked context menu item.
        /// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
        [Description("Image for a checked context menu item.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Checked
        {
            get => _checked;

            set
            {
                if (_checked != value)
                {
                    _checked = value;
                    PerformNeedPaint();
                }
            }
        }

        /// <summary>
        /// Resets the Checked property to its default value.
        /// </summary>
        public void ResetChecked()
        {
            Checked = null;
        }
        #endregion

        #region Indeterminate
        /// <summary>
        /// Gets and sets the image for an indeterminate context menu item.
        /// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
        [Description("Image for an indeterminate context menu item.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image Indeterminate
        {
            get => _indeterminate;

            set
            {
                if (_indeterminate != value)
                {
                    _indeterminate = value;
                    PerformNeedPaint();
                }
            }
        }

        /// <summary>
        /// Resets the Indeterminate property to its default value.
        /// </summary>
        public void ResetIndeterminate()
        {
            Indeterminate = null;
        }
        #endregion

        #region SubMenu
        /// <summary>
        /// Gets and sets an image indicating a sub-menu on a context menu item.
        /// </summary>
        [KryptonPersist(false)]
        [Category("Visuals")]
        [Description("Image indicating a sub-menu on a context menu item.")]
        [DefaultValue(null)]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Image SubMenu
        {
            get => _subMenu;

            set
            {
                if (_subMenu != value)
                {
                    _subMenu = value;
                    PerformNeedPaint();
                }
            }
        }

        /// <summary>
        /// Resets the SubMenu property to its default value.
        /// </summary>
        public void ResetSubMenu()
        {
            SubMenu = null;
        }
        #endregion
    }
}
