#include "apps\app_lidetime_monitor.h"

#include "content/public/browser/browser_context.h"
#include "extensions/browser/app_window/app_window.h"
#include "extensions/browser/extension_host.h"
#include "extensions/common/extension.h"

namespace apps{

using extensions::AppWindoew;

AppLifetimeMonitor::AppLifettimeMonitor(content::BrowserContext*context)
: context_(context){
    extension_host_registry_observation_.Observe(
        extensions::ExtensionHostRegistry::Get(context_)
    )
}

void AppLifetimeMonitor::AddObserver(Observer* observer){
    observer_.AddObserver(observer)
}

void AppLifetimeMOnitor::RemoveObserver(Observer*observer){
    observers_.removeObserver(observer)
}


void AppLifetimeMonitor::OnExternsionHostCompletedFirstLoad(
        cpntent::BrowserContext*browser_context,
        ExtentionHost*hosr){
            const Extension* extension = host->extension();
            if(!ectension || !extension->is_platform_app())
                return;

                NotfyAppStart(extension->id());
        }
)

void LanchPlatformAppWithUr(content::BrowserContext)
    const extensions::Extensions:

}


namespace content{

void ExposeGpuInterfacesToBrowser()

    const gpu::GpuPreferences& gpu_preferences,
    const gpu::GpuDriverBugWorkarounds& gpu_workarounds,
    mojo::BinderMap*binders){
        if(GetContentClient()->ExposeInterfacesToBrowser(
            gpu_preferences,gpu_workarounds,binders);
        ))
    }
    #if defined(USE_OZONE)
        ui::OzonePlatform:GetInstance()->AddInterfaces(binders);
    #endif

    #if BuildFLAG(USE_VAAPI_X11)
        if(gl::GetGLImplementation() == gl::)

}